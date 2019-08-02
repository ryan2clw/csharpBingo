import React from 'react';
import styled from 'styled-components';
import { Flex } from 'reflexbox';
import { connect } from 'react-redux';
import Board from './BingoBoard';
import BallBoard from './BallBoard';
import {actionCreators} from '../store/Numbers';
import {ballAction} from '../store/Balls';
import { Container } from 'reactstrap';
import Spinner from './Spinner';
import './BingoPage.css';
import { danger } from '../store/Message';

const Body = styled.div`
    min-height:600px;
`

class BingoPage extends React.Component {

    updateBingo = () => {
        this.props.dispatch(danger("You did not win the bingo game, nice try though!"));
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
        console.log("calledBalls", calledBalls);        
        return [...Array(cardCount)].map((_, i) => {
            return (<Board updateBingo={this.updateBingo} calledBalls={calledBalls} key={"Card-" + i.toString()} games={cards.cards[i] || []} />);
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
            <Container justify='space-evenly' className='pb-3' >
                <div className="row">
                    <div className="col-md-9">
                        <div className="row d-flex flex-row justify-content-center align-items-center">
                            {this.bingoBoards(cards.cards.length)}
                        </div>
                    </div>
                    <div className="col-md-3 d-flex flex-column align-items-center justify-content-center pt-4">
                        <BallBoard calledBalls={calledBalls} scoreCard={cards.scoreCard} />
                    </div>
                </div>
            </Container>) :
            (<Container justify='space-evenly' className='pb-3' >
                <div className="row">
                    <Body className="col-md-12">
                        <Spinner />
                    </Body>
                </div>
            </Container>);    
    }
}
function mapStateToProps(state) {
    const { games } = state.games;
    return {
            cards:games,
            calledBalls: state.balls.balls
    }
}
export default connect(mapStateToProps)(BingoPage);
// export default BingoPage;