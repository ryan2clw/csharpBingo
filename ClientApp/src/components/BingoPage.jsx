import React from 'react';
import styled from 'styled-components';
import { Flex } from 'reflexbox';
import { connect } from 'react-redux';
import Board from './BingoBoard';
import BallBoard from './BallBoard';
import {actionCreators} from '../store/Numbers';
import {ballAction} from '../store/Balls';
import { Alert } from 'reactstrap';
import './BingoPage.css';

const BoardHeader = styled.div`
    color:#337ab7;
    font-size: 30px;
`;
const FlexTall = styled(Flex)`
    height:50%;
    font-size: 40px;
`
const RoundAlert = styled(Alert)`
    border-radius: 50px;
`

class BingoPage extends React.Component {

    numbers = (cardCount = 2) => this.props.dispatch(actionCreators.requestNumbers(cardCount));
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
            return (<Board calledBalls={calledBalls} key={"Card-" + i.toString()} games={cards.cards[i] || []} />);
        });
    };

    componentDidMount(){
        fetch("http://localhost:5000/api/Bingo/StartGame");
        this.numbers(this.props.cardCount);
        this.handleBingo();
    }

    render() {
        const { cards, calledBalls } = this.props;
        return cards && cards.cards ?
        (
            <Flex justify='space-evenly'>
                { console.log("Bingo Page props", this.props)}
                    <div>
                        <div>
                            <Flex justify='center'>
                                <BoardHeader>Bingo Cards</BoardHeader>
                                {this.bingoBoards(cards.cards.length)}
                            </Flex>
                        </div>
                    </div>
                <div>
                    <FlexTall column justify='flex-start' align='center'>
                        <BoardHeader>Current Number</BoardHeader>
                        <RoundAlert color="success">
                            { this.props.lastNumber ? this.props.lastNumber : "Game started, round 0!" }
                        </RoundAlert>
                    </FlexTall>
                </div>
                <div>
                    <Flex justify='center'>
                        <BoardHeader>Called Balls</BoardHeader>
                    </Flex>
                    <BallBoard calledBalls={calledBalls} scoreCard={cards.scoreCard} />
                </div>
            </Flex>
            ) :
            (<h3>DATA LOADING...{console.log("-------------------------- NO DATA FOR BINGO PAGE YET -------------------")}</h3>);
    }
}
function mapStateToProps(state, ownProps) {
    const { games } = state.games;
    return {
            cards:games,
            lastNumber: state.balls.balls[0],
            calledBalls: state.balls.balls
    }
}
export default connect(mapStateToProps)(BingoPage);
// export default BingoPage;