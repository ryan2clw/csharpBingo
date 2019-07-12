import React, {useState} from 'react';
import styled from 'styled-components';
import { connect } from 'react-redux';
import { Button } from 'reactstrap';
//import actionAlerts from '../store/Message';

// Create a Title component that'll render an <h1> tag with some styles
const BingoHeader = styled.div`
    width: 100px;
    margin-bottom:5px;
`;

// Create a Wrapper component that'll render a <section> tag with some styles
const Wrapper = styled.section`
  padding: 1rem;
  background: #ff8c90;
  height: 540px;
  border-radius: 15px;
`;
const Square = styled.div`
  background: black;
  height: 75px;
  width: 75px;
  margin: 2px;
`;
export const Squares = () => {
  let arr = [...Array(5)].map((_, i) => {
    return (<Square key={i}></Square>)
  });
  return (
    <div className="d-flex flex-row justify-content-center">
      {arr}
    </div>
  )
};

class Board extends React.Component {

  constructor(props){
    super(props);
    this.handleBingo = this.handleBingo.bind(this);
  }
  handleBingo = () => alert('YOU FUCKING WON DUDE');
  squares = (columnCount = 5) => {
    let arr = [...Array(columnCount)].map((_, i) => {
      return (<Square key={i}></Square>)
    });
    return (
      <div className="d-flex flex-row justify-content-center">
        {arr}
      </div>
    )
  };
  rows = (rowCount = 5) => [...Array(rowCount)].map((_, i) => {
    return this.squares(5);
  });

  render(){
    return(
    <Wrapper className="align-content-center col-md-5">
      <BingoHeader>
        <img src='/BingoBalls.png' />
      </BingoHeader>
      { this.rows(5) }
        <div className="d-flex flex-row justify-content-center mt-1" onClick={this.handleBingo}>
          <img src="/BingoButton.png" />
        </div>
    </Wrapper>);
  }
}
export default Board;