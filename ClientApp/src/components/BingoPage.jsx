import React from 'react';
import styled from 'styled-components';
import { Flex } from 'reflexbox';
import { connect } from 'react-redux';
import Board from './BingoBoard';
import BallBoard from './BallBoard';
import {actionCreators} from '../store/Numbers';
import {ballAction} from '../store/Balls';
//import QuadBounce, {Ball} from './Ball';
import { Alert } from 'reactstrap';

const BoardHeader = styled.div`
    color:#337ab7;
    font-size: 40px;
`;
const FlexTall = styled(Flex)`
    height:50%;
    font-size: 40px;
`
const RoundAlert = styled(Alert)`
    border-radius: 50px;
`

class BingoPage extends React.Component {

    numbers = () => this.props.dispatch(actionCreators.requestNumbers(1));
    sleep = (ms) => {
        return new Promise(resolve => setTimeout(resolve, ms));
      }
    handleBingo = async () => {
        for(let i=0;i<=4;i++){
          this.props.dispatch(ballAction.getRounds());
          await(this.sleep(5000));
        }
      };

    componentDidMount(){
        fetch("http://localhost:5000/api/Bingo/StartGame");
        this.numbers();
        this.handleBingo();
    }

    render() {
        const { cards } = this.props;
        return cards && cards.cards ?
        (
            <Flex justify='space-evenly' w='80%'>
                <div>
                    <Flex justify='center'>
                        <BoardHeader>Called Balls</BoardHeader>
                    </Flex>
                    <BallBoard scoreCard={cards.scoreCard} />
                </div>
                <div>
                    <FlexTall column justify='center' align='center'>
                        <BoardHeader>Current Number</BoardHeader>
                        <RoundAlert color="success">
                            { this.props.lastNumber ? this.props.lastNumber : "420" }
                        </RoundAlert>
                    </FlexTall>
                </div>
                <div>
                    <Flex justify='center'>
                        <BoardHeader>Bingo Card</BoardHeader>
                    </Flex>
                    <Board games={cards.cards[0] || []} />
                </div>
            </Flex>
            ) :
            (<h3>DATA LOADING...{console.log("-------------------------- NO DATA FOR BINGO PAGE YET -------------------")}</h3>);
    }
}
function mapStateToProps(state, ownProps) {
    const { games } = state.games;
    console.log("BingoPage state", state.balls);
    return {
            ...ownProps,
            cards:games,
            lastNumber: state.balls.balls[0]
    }
    // const {games, balls, ball} = state;
    // return {
    //      games,
    //      balls,
    //      ball
    // };
}
export default connect(mapStateToProps)(BingoPage);
// export default BingoPage;