import React from 'react';
import { Flex } from 'reflexbox';
import styled from 'styled-components';
import {actionCreators} from '../store/Numbers';
import Square from './Square';
import {ballAction} from '../store/Balls';
import { connect } from 'react-redux';

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
    //console.log("Initial bingoBoard props", this.props);
  }
  componentDidMount(){
    this.numbers();
  }
  numbers = () => this.props.dispatch(actionCreators.requestNumbers(1));

  sleep = (ms) => {
    return new Promise(resolve => setTimeout(resolve, ms));
  }

  handleBingo = async () => {
    for(let i=0;i<=5;i++){
      this.props.dispatch(ballAction.getRounds());
      await(this.sleep(5000));
    }
  };
  squares = (rowNumber = "0", columnCount, rowJSON) => rowJSON ? (
        <Flex key={"Row(" + rowNumber + ")"}>
          {[...Array(columnCount)].map((_, i) => {
              let reactKey = "Square(" + rowNumber + "," + i + ")";
              let isCalled = false;
              let ticketNumber = Object.values(rowJSON)[i].toString();
              if(reactKey==="Square(2,2)"){
                isCalled = true;
                ticketNumber = "FREE";
              }
              return (<Square isCalled={isCalled} ticketNumber={ticketNumber} key={reactKey} />)
          })}
        </Flex>) : (
        <Flex key={"Row(" + rowNumber + ")"} justify='center'><h6>----Row data Loading----</h6></Flex>);
  rows = (gameJSON, rowCount = 5, columnCount = 5) => (
       [...Array(rowCount)].map((_, i) => this.squares(i.toString(), columnCount, gameJSON[i])))

  render(){
    const games = this.props.games;
    //console.log("bingoBoard's render props:", games);
    return games ?
    (
    <Wrapper className="align-content-center">
      <BingoHeader>
        <img src='/BingoBalls.png' alt="Ball Columns" width="100%"/>
      </BingoHeader>
        { this.rows(games, 5, 5) /* Configurable, can send row and column lengths */ }
        <div className="d-flex flex-row justify-content-center mt-1 pointy" onClick={this.handleBingo}>
          <img src="/BingoButton.png" alt="Bingo!"/>
        </div>
    </Wrapper>)
    :(
        <h3>N/A</h3>
    );
  }
}
function mapStateToProps(state, ownProps) {
    //console.log("Bingo board mapStateToProps state", state);
    // console.log("Bingo board mapStateToProps ownProps", {
    //     ...ownProps,
    //     games: state.games ? state.games.games : []
    // });    
    // if(ownProps.height === "50px"){
    //     console.log("<---------Initializes with SQUARE RENDERED below, # of Squares that this function checks--------------------------------------------->", ownProps);
    // }    
    return {
        ...ownProps,
        games:state.games ? state.games.games : []
    };
}
export default connect(mapStateToProps)(Board);