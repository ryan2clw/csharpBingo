import React from 'react';
import { Flex } from 'reflexbox';
import styled from 'styled-components';
import Square from './Square';
import { Alert } from 'reactstrap';

const TopHeader = styled.div`
	width: 132%;
	margin-left: -15%;
	margin-top: -13%;
`
const BingoHeader = styled.div`
    margin-bottom: 1px;
    width: 132%;
    margin-left: -15%;
`;
const Wrapper = styled.section`
    padding: 1rem;
    background: #d6d2cb center url("WoodBack.png");
    border-radius: 15px;
    width: 249px;
    height:600px;
`;
const StatusDiv = styled.div`
    border-radius: 22px;
`
const RoundDiv = styled.div`
    border-radius: 22px;
    color: #0c5460;
    background-color: #d1ecf1;
    border-color: #bee5eb;
    width: 36px;
    margin: 1px;
    padding: 5px;
    text-align: center;
`
const BoardHeader = styled.div`
    font-size: 17px;
    padding: 5px;
`;

class BallBoard extends React.Component {

  squares = (rowNumber = "0", columnCount, rowJSON) => {
      let numBas = Object.values(rowJSON);
      const calledBalls = this.props.calledBalls;
      return(
        <Flex justify='center' key={"Row(" + rowNumber + ")"} className="aqua">
        {[...Array(columnCount)].map((_, i) => {
            let reactKey = "Square(" + rowNumber + "," + i + ")";
            let ticketNumber= numBas[i].toString();
            // console.log("CALLED BALLS", this.props);
            if(calledBalls && calledBalls.length && calledBalls.includes(ticketNumber)){
              //console.log("CALLED NUMBER", this.props);
              return (<Square height="30px" width="50px" ticketNumber={ticketNumber} key={reactKey} className="ticket-number called" />)
            }
            return (<Square height="30px" width="50px" ticketNumber={ticketNumber} key={reactKey} className="ticket-number" />)
        })}
      </Flex>);
    };
  rows = (gameJSON, rowCount = 5, columnCount = 5) => {
    return [...Array(rowCount)].map((_, i) => this.squares(i.toString(), columnCount, gameJSON[i]))
  };
  balls = (ballArray) => {
    let ret = [];
    ballArray.forEach(ball => {
      ret.push(<RoundDiv className='round-ball'>{ball}</RoundDiv>);
    });
    return ret;
  }

  render(){
    const games = this.props.scoreCard;   
    return games && games.rows ?
    (<Wrapper className="align-content-center">
      <TopHeader>
        <img src='/BingoBalls.png' alt="Ball Columns" width="100%"/>
      </TopHeader>
      <StatusDiv className="d-flex flex-row justify-content-center p-1 current-number">
        <BoardHeader></BoardHeader>
        <div className="five-balls">
            { this.balls(this.props.calledBalls.reverse().slice(-5)) }
        </div>
      </StatusDiv>
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