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

    numbers = () => this.props.dispatch(actionCreators.requestNumbers(2));
    sleep = (ms) => {
        return new Promise(resolve => setTimeout(resolve, ms));
    }
    handleBingo = async () => {
        for (let i = 0; i <= 75; i++) {
            this.props.dispatch(ballAction.getRounds());
            await (this.sleep(5000));
        }
    };
    bingoBoards = (cardCount = 2) => {
        const { cards, calledBalls } = this.props;
    return [...Array(cardCount)].map((_, i) => {
        return (<Board calledBalls={calledBalls} games={cards.cards[i] || []} />);
    })};

    componentDidMount(){
        fetch("http://localhost:5000/api/Bingo/StartGame");
        this.numbers();
        this.handleBingo();
    }

    render() {
        const { cards, calledBalls } = this.props;
        return cards && cards.cards ?
        (
            <Flex justify='space-evenly' w='80%'>
                <div>
                    <Flex justify='center'>
                        <BoardHeader>Called Balls</BoardHeader>
                    </Flex>
                    <BallBoard calledBalls={calledBalls} scoreCard={cards.scoreCard} />
                </div>
                <div>
                    <FlexTall column justify='center' align='center'>
                        <BoardHeader>Current Number</BoardHeader>
                        <RoundAlert color="success">
                            { this.props.lastNumber ? this.props.lastNumber : "Game started, round 0!" }
                        </RoundAlert>
                    </FlexTall>
                </div>
                <div>
                    <Flex justify='center'>
                        <BoardHeader>Bingo Card</BoardHeader>
                    </Flex>
                    {this.bingoBoards(2)}
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
            lastNumber: state.balls.balls[0],
            calledBalls: state.balls.balls
    }
}
export default connect(mapStateToProps)(BingoPage);
// export default BingoPage;