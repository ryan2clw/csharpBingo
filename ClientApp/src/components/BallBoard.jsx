import React from 'react';
import { Flex } from 'reflexbox';
import styled from 'styled-components';
import Square from './Square';
import ShinyBall from './ShinyBall';
import Bball from './images/B-Ball.png'; 
import Iball from './images/I-Ball.png';
import Nball from './images/N-Ball.png';
import Gball from './images/G-Ball.png';
import Oball from './images/O-Ball.png';

const Wrapper = styled.div`
    padding: 1rem;
    background: #d6d2cb center url("WoodBack.png");
    border-radius: 15px;
    width: 249px;
    height:594px;
`;
const StatusDiv = styled.div`
    border-radius: 22px;
`

class BallBoard extends React.Component {
  
  headerNames = (i) => {
    switch(i){
      case(0):
        return "B";
        case(1):
        return "I";
        case(2):
        return "N";
        case(3):
        return "G";
        case(4):
        return "O";
      default:
        return "B";
    }
  }

  squares = (rowNumber = "0", columnCount, rowJSON) => {
      let numBas = Object.values(rowJSON);
      const calledBalls = this.props.calledBalls;

    return (
      <Flex column justify='center' key={"Row(" + rowNumber + ")"} className="aqua">
        <Flex >
        {rowNumber == "0" &&
          [...Array(columnCount)].map((_, i) => {
            let reactKey = "Header(" + rowNumber + "," + i + ")";
            return (<Square height="30px" width="50px" ticketNumber={this.headerNames(i)} key={reactKey} className="ticket-number bingo-header"></Square>)
          })}
        </Flex>
        <Flex >
          {[...Array(columnCount)].map((_, i) => {
            let reactKey = "Square(" + rowNumber + "," + i + ")";
            let ticketNumber = numBas[i].toString();
            if (calledBalls && calledBalls.length && calledBalls.includes(ticketNumber)) {
              return (<Square height="30px" width="50px" ticketNumber={ticketNumber} key={reactKey} className="ticket-number called" />)
            }
            return (<Square height="30px" width="50px" ticketNumber={ticketNumber} key={reactKey} className="ticket-number" />)
          })}
        </Flex>
      </Flex>);
    };
  rows = (gameJSON, rowCount = 5, columnCount = 5) => {
    return [...Array(rowCount)].map((_, i) => this.squares(i.toString(), columnCount, gameJSON[i]))
  };
  balls = (ballArray) => {
    let ret = [];
    ballArray.forEach(ball => {
      console.log("ball", parseInt(ball));
      let myBall = parseInt(ball);
      if(myBall>0 && myBall <15){
        ret.push(<ShinyBall letter={Bball} className='round-div'>{ball}</ShinyBall>);
      }else if(myBall>=16 && myBall <31){
        ret.push(<ShinyBall letter={Iball} className='round-div'>{ball}</ShinyBall>);
      }else if(myBall>=31 && myBall <46){
        ret.push(<ShinyBall letter={Nball} className='round-div'>{ball}</ShinyBall>);
      }else if(myBall>=46 && myBall <61){
        ret.push(<ShinyBall letter={Gball} className='round-div'>{ball}</ShinyBall>);
      }else if(myBall>=61){
        ret.push(<ShinyBall letter={Oball} className='round-div'>{ball}</ShinyBall>);
      }
    });
    return ret;
  }

  render(){
    const games = this.props.scoreCard;   
    return games && games.rows ?
    (<Wrapper className="align-content-center">
      <StatusDiv className="d-flex flex-row justify-content-center p-1 current-number">
        <div className="five-balls">
            { this.balls(this.props.calledBalls.reverse().slice(-5)) }
        </div>
      </StatusDiv>
        {
          this.rows(games.rows, 15, 5)/* Configurable, can send row and column lengths */ 
        }
    </Wrapper>)
    :(
        <h3>N/A</h3>
    );
  }
}
export default BallBoard;