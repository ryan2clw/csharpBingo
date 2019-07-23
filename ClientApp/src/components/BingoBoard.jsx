import React from 'react';
import { Flex } from 'reflexbox';
import styled from 'styled-components';
import Square from './Square';

// Create a Title component that'll render an <h1> tag with some styles
const BingoHeader = styled.div`
    margin-bottom:5px;
`;
// Create a Wrapper component that'll render a <section> tag with some styles
const Wrapper = styled.section`
  padding: 1rem;
  background: #ff8c90;
  height: 390px;
  border-radius: 15px;
  width: 300px;
`;

class Board extends React.Component {

  squares = (rowNumber = "0", columnCount, rowJSON) => {
    let numBas = Object.values(rowJSON);
    const calledBalls = this.props.calledBalls;
    return(
    <Flex justify='center' key={"Row(" + rowNumber + ")"}>
      {[...Array(columnCount)].map((_, i) => {
          let reactKey = "Square(" + rowNumber + "," + i + ")";
          let ticketNumber= numBas[i].toString();
          // console.log("CALLED BALLS", this.props);
          if(reactKey==="Square(2,2)"){
            ticketNumber = "FREE";
            return (<Square className="ticket-number called" ticketNumber={ticketNumber} key={reactKey} />);
          }
          if(calledBalls && calledBalls.length && calledBalls.includes(ticketNumber)){
            //console.log("CALLED NUMBER", this.props);
            return (<Square ticketNumber={ticketNumber} key={reactKey} className="ticket-number called" />)
          }
          return (<Square ticketNumber={ticketNumber} key={reactKey} className="ticket-number" />)
      })}
    </Flex>);
  };
  rows = (gameJSON, rowCount = 5, columnCount = 5) => (
       [...Array(rowCount)].map((_, i) => this.squares(i.toString(), columnCount, gameJSON[i])))

  render(){
    const games = this.props.games;
    return games && games.rows ?
    (
    <Wrapper className="align-content-center">
      <BingoHeader>
        <img src='/BingoBalls.png' alt="Ball Columns" width="100%"/>
      </BingoHeader>
        { this.rows(games.rows, 5, 5) /* Configurable, can send row and column lengths */ }
        <div className="d-flex flex-row justify-content-center mt-1 pointy"  >
          <img src="/BingoButton.png" alt="Bingo!"/>
        </div>
    </Wrapper>)
    :(
        <h3>N/A</h3>
    );
  }
}
export default Board;