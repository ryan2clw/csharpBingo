import React from 'react';
import { Flex } from 'reflexbox';
import styled from 'styled-components';
import Square from './Square';
//import { connect } from 'react-redux';

// Create a Title component that'll render an <h1> tag with some styles
const BingoHeader = styled.div`
    margin-bottom:5px;
`;
// Create a Wrapper component that'll render a <section> tag with some styles
const Wrapper = styled.section`
  padding: 1rem;
  background: #ff8c90;
  border-radius: 15px;
  width: 300px;
`;

class BallBoard extends React.Component {

  handleBingo = () => {alert('YOU FUCKING WON DUDE')};
  squares = (rowNumber = "0", columnCount, rowJSON) => {
      let numBas = Object.values(rowJSON);
      const calledBalls = this.props.calledBalls;
      return(
      <Flex justify='center' key={"Row(" + rowNumber + ")"}>
        {[...Array(columnCount)].map((_, i) => {
            let reactKey = "Square(" + rowNumber + "," + i + ")";
            let ticketNumber= numBas[i].toString();
            // console.log("CALLED BALLS", this.props);
            if(calledBalls && calledBalls.length && calledBalls.includes(ticketNumber)){
              //console.log("CALLED NUMBER", this.props);
              return (<Square height="40px" width="50px" ticketNumber={ticketNumber} key={reactKey} className="ticket-number called" />)
            }
            return (<Square height="40px" width="50px" ticketNumber={ticketNumber} key={reactKey} className="ticket-number" />)
        })}
      </Flex>);
    };
  rows = (gameJSON, rowCount = 5, columnCount = 5) => {
    return [...Array(rowCount)].map((_, i) => this.squares(i.toString(), columnCount, gameJSON[i]))
  };

  render(){
    const games = this.props.scoreCard;   
    return games && games.rows ?
    (<Wrapper className="align-content-center">
      <BingoHeader>
        <img src='/BingoBalls.png' alt="Ball Columns" width="100%"/>
      </BingoHeader>
        {
          this.rows(games.rows, 15, 5)/* Configurable, can send row and column lengths */ 
        }
      <BingoHeader>
        <img src='/BingoBalls.png' alt="Ball Columns" width="100%"/>
      </BingoHeader>
    </Wrapper>)
    :(
        <h3>N/A</h3>
    );
  }
}
export default BallBoard;