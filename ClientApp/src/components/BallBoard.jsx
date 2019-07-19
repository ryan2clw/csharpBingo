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
  border-radius: 15px;
  width: 300px;
`;

class BallBoard extends React.Component {

  handleBingo = () => {alert('YOU FUCKING WON DUDE')};
  squares = (rowNumber = "0", columnCount, rowJSON) => {
      // let newNumba = this.props.ball || -1;
      let numBas = Object.values(rowJSON);
      return(
      <Flex justify='center' key={"Row(" + rowNumber + ")"}>
        {[...Array(columnCount)].map((_, i) => {
            let reactKey = "Square(" + rowNumber + "," + i + ")";
            // if(newNumba.ball && newNumba.ball.toString() === numBas[i]){
            //   return (<Square background="green" height="40px" width="50px" ticketNumber={numBas[i].toString()} key={reactKey} />)
            // }
            return (<Square background="black" height="40px" width="50px" ticketNumber={numBas[i].toString()} key={reactKey} />)
        })}
      </Flex>);
    };
  rows = (gameJSON, rowCount = 5, columnCount = 5) => {
    return [...Array(rowCount)].map((_, i) => this.squares(i.toString(), columnCount, gameJSON[i]))
  };
  balls = () => [
    {
      "b": "1",
      "i": "16",
      "n": "31",
      "g": "46",
      "o": "61"
    },
    {
      "b": "2",
      "i": "17",
      "n": "32",
      "g": "47",
      "o": "62"
    },
    {
      "b": "3",
      "i": "18",
      "n": "33",
      "g": "48",
      "o": "63"
    },
    {
      "b": "4",
      "i": "19",
      "n": "34",
      "g": "49",
      "o": "64"
    },
    {
      "b": "5",
      "i": "20",
      "n": "35",
      "g": "50",
      "o": "65"
    },
    {
      "b": "6",
      "i": "21",
      "n": "36",
      "g": "51",
      "o": "66"
    },
    {
      "b": "7",
      "i": "22",
      "n": "37",
      "g": "52",
      "o": "67"
    },
    {
      "b": "8",
      "i": "23",
      "n": "38",
      "g": "53",
      "o": "68"
    },
    {
      "b": "9",
      "i": "24",
      "n": "39",
      "g": "54",
      "o": "69"
    },
    {
      "b": "10",
      "i": "25",
      "n": "40",
      "g": "55",
      "o": "70"
    },
    {
      "b": "11",
      "i": "26",
      "n": "41",
      "g": "56",
      "o": "71"
    },
    {
      "b": "12",
      "i": "27",
      "n": "42",
      "g": "57",
      "o": "72"
    },
    {
      "b": "13",
      "i": "28",
      "n": "43",
      "g": "58",
      "o": "73"
    },
    {
      "b": "14",
      "i": "29",
      "n": "44",
      "g": "59",
      "o": "74"
    },
    {
      "b": "15",
      "i": "30",
      "n": "45",
      "g": "60",
      "o": "75"
    }
  ];

  render(){      
    return(
    <Wrapper className="align-content-center">
      <BingoHeader>
        <img src='/BingoBalls.png' alt="Ball Columns" width="100%"/>
      </BingoHeader>
        {  this.rows(this.balls(), 15, 5)/* Configurable, can send row and column lengths */ }
      <BingoHeader>
        <img src='/BingoBalls.png' alt="Ball Columns" width="100%"/>
      </BingoHeader>
    </Wrapper>);
  }
}
export default BallBoard;