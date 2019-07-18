import React from 'react';
import styled from 'styled-components';
import { Flex } from 'reflexbox';
import { connect } from 'react-redux';
import Board from './BingoBoard';
import BallBoard from './BallBoard';
//import QuadBounce, {Ball} from './Ball';
import {actionCreators} from '../store/Numbers';
import { Alert } from 'reactstrap';

const BoardHeader = styled.div`
    color:#337ab7;
    font-size: 40px;
`;
const FlexTall = styled(Flex)`
    height:50%;
    font-size: 40px;
`

class BingoPage extends React.Component {

    componentDidMount(){
        this.numbers();
    }

    numbers = () => this.props.dispatch(actionCreators.requestNumbers(1));

    render() {
        const {games, balls, ball} = this.props;
        return (
            games.games.length ? (
            <Flex justify='space-evenly' w='80%'>
                <div>
                    <Flex justify='center'>
                        <BoardHeader>Called Balls</BoardHeader>
                    </Flex>
                    <BallBoard ball= { ball || -1 } />
                </div>
                {console.log("BingoPage props", this.props)}
                <div>
                    <FlexTall column justify='center' align='center'>
                        <BoardHeader>Current Number</BoardHeader>
                        <Alert color="success">
                            { ball > 0 ? ball : 420 }
                        </Alert>
                    </FlexTall>
                </div>
                <div>
                    <Flex justify='center'>
                        <BoardHeader>Bingo Card</BoardHeader>
                    </Flex>
                    <Board games={ games } dispatch= { this.props.dispatch } balls= { balls || {}} />
                </div>
            </Flex>
            ) :
            <h3>DATA LOADING...{console.log("--------------------------NO DATA-------------------", games.games)}</h3>
        );
    }
}
function mapStateToProps(state) {
    const {games, balls, ball} = state;
    return {
         games,
         balls,
         ball
    };
}
export default connect(mapStateToProps)(BingoPage);