import React from 'react';
//import styled from 'styled-components';
import { Flex } from 'reflexbox';
import { connect } from 'react-redux';
import Board from './BingoBoard';
import BallBoard from './BallBoard';
import {actionCreators} from '../store/Numbers';
import {ballAction} from '../store/Balls';
//import { Alert } from 'reactstrap';
//import { danger } from '../store/Message';
import './BingoPage.css';

// const BoardHeader = styled.div`
//     font-size: 18px;
//     padding: 5px;
// `;
// const RoundAlert = styled(Alert)`
//     border-radius: 22px;
// `

class BingoPage extends React.Component {

    handleClick = () => {
        alert('Click happened');
        console.log('Click happened', this.props);
    };

    numbers = (cardCount = 2) => this.props.dispatch(actionCreators.requestNumbers(cardCount));
    sleep = (ms) => {
        return new Promise(resolve => setTimeout(resolve, ms));
    }
    drawRound = async () => {
        for (let i = 0; i <= 75; i++) {
            this.props.dispatch(ballAction.getRounds());
            await (this.sleep(5000));
        }
    };
    bingoBoards = (cardCount = 2) => {
        const { cards, calledBalls } = this.props;
        return [...Array(cardCount)].map((_, i) => {
            return (<Board onClick={this.handleClick} calledBalls={calledBalls} key={"Card-" + i.toString()} games={cards.cards[i] || []} />);
        });
    };

    componentDidMount(){
        fetch("http://localhost:5000/api/Bingo/StartGame");
        this.numbers(this.props.cardCount);
        this.drawRound();
    }

    render() {
        const { cards, calledBalls } = this.props;
        return cards && cards.cards ?
        (
            <Flex justify='space-evenly' className="row w-100">
                <div className="col-md-8">
                    <div className="row d-flex flex-row justify-content-center align-items-center">
                        {this.bingoBoards(cards.cards.length)}
                    </div>
                </div>
                <div className="col-md-3 d-flex flex-column align-items-center">
                    <BallBoard lastNumber={this.props.lastNumber ? this.props.lastNumber : "N/A"} calledBalls={calledBalls} scoreCard={cards.scoreCard} />
                </div>
            </Flex>) :
        <h3>DATA LOADING...{console.log("-------------------------- NO DATA FOR BINGO PAGE YET -------------------")}</h3>;
    }
}
function mapStateToProps(state, ownProps) {
    const { games } = state.games;
    return {
            cards:games,
            lastNumber: state.balls.balls ? state.balls.balls[0] : "N/A",
            calledBalls: state.balls.balls
    }
}
export default connect(mapStateToProps)(BingoPage);
// export default BingoPage;