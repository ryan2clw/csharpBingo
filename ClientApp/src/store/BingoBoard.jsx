import React from 'react';
import styled from 'styled-components';

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
const Square = styled.div`
  background: black;
  height: 54px;
  width: 54px;
  margin: 1px;
`;

class Board extends React.Component {

  constructor(props){
    super(props);
    this.handleBingo = this.handleBingo.bind(this);
  }
  handleBingo = () => alert('YOU FUCKING WON DUDE');
  squares = (rowNumber = "0", columnCount = 5) => (
      <div className="d-flex flex-row justify-content-center" key={"Row(" + rowNumber + ")"}>
        {[...Array(columnCount)].map((_, i) => <Square key={"Square(" + rowNumber + "," + i + ")"}></Square>)}
      </div>
    );
  rows = (rowCount = 5) => [...Array(rowCount)].map((_, i) => this.squares(i.toString(), rowCount));

  render(){
    return(
    <Wrapper className="align-content-center">
      <BingoHeader>
        <img src='/BingoBalls.png' alt="Ball Columns" width="100%"/>
      </BingoHeader>
      { this.rows() }
        <div className="d-flex flex-row justify-content-center mt-1 pointy" onClick={this.handleBingo}>
          <img src="/BingoButton.png" alt="Bingo!"/>
        </div>
    </Wrapper>);
  }
}
export default Board;