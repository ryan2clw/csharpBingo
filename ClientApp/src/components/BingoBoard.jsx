import React from 'react';
import { Flex } from 'reflexbox';
import styled from 'styled-components';
import Square from './Square';
import {ballAction} from '../store/Balls';

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

  constructor(props){
    super(props);
    this.handleBingo = this.handleBingo.bind(this);
    console.log("Board props", this.props);
  }
  sleep = (ms) => {
    return new Promise(resolve => setTimeout(resolve, ms));
  }

  handleBingo = async () => {
    for(let i=0;i<=75;i++){
      this.props.dispatch(ballAction.getRound());
      await(this.sleep(5000));
    }
  };
  squares = (rowNumber = "0", columnCount, rowJSON) => {
      let numBas = Object.values(rowJSON);
      return(
        <Flex key={"Row(" + rowNumber + ")"}>
          {[...Array(columnCount)].map((_, i) => {
              let reactKey = "Square(" + rowNumber + "," + i + ")";
              let background = "black";
              let ticketNumber = numBas[i].toString();
              if(reactKey==="Square(2,2)"){
                background="green";
                ticketNumber = "FREE";
              }
              return (<Square background={background} ticketNumber={ticketNumber} key={reactKey} />)
          })}
        </Flex>);
    };
  rows = (gameJSON, rowCount = 5, columnCount = 5) => {
    return [...Array(rowCount)].map((_, i) => this.squares(i.toString(), columnCount, gameJSON[i]))
  };

  render(){
    const { games } = this.props.games;
    return(
    <Wrapper className="align-content-center">
      <BingoHeader>
        <img src='/BingoBalls.png' alt="Ball Columns" width="100%"/>
      </BingoHeader>
        { this.rows(games, 5, 5)/* Configurable, can send row and column lengths */ }
        <div className="d-flex flex-row justify-content-center mt-1 pointy" onClick={this.handleBingo}>
          <img src="/BingoButton.png" alt="Bingo!"/>
        </div>
    </Wrapper>);
  }
}
export default Board;