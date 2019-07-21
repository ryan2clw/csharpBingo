import React from 'react';
import styled from 'styled-components';
import { Flex } from 'reflexbox';
// import { connect } from 'react-redux';
import Board from './BingoBoard';
import BallBoard from './BallBoard';
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

    // componentDidMount(){
    //     this.numbers();
    // }
    // numbers = () => this.props.dispatch(actionCreators.requestNumbers(1));

    render() {
        //const {games} = this.props;
        // console.log("BINGO PAGE RENDERS PROPS:", this.props);
        //const balls = (this.props.balls && this.props.balls.balls) || [];
        const ball = (this.props.balls && this.props.balls.ball) || "420";             
        return (
            <Flex justify='space-evenly' w='80%'>
                <div>
                    <Flex justify='center'>
                        <BoardHeader>Called Balls</BoardHeader>
                    </Flex>
                    <BallBoard ball= { ball } />
                </div>
                <div>
                    <FlexTall column justify='center' align='center'>
                        <BoardHeader>Current Number</BoardHeader>
                        <RoundAlert color="success">
                            { ball }
                        </RoundAlert>
                    </FlexTall>
                </div>
                <div>
                    <Flex justify='center'>
                        <BoardHeader>Bingo Card</BoardHeader>
                    </Flex>
                    <Board />
                </div>
            </Flex>
            ); //:
            //<h3>DATA LOADING...{console.log("-------------------------- NO DATA FOR BINGO PAGE YET -------------------")}</h3>
        //);
    }
}
// function mapStateToProps(state, ownProps) {
//     const { games } = state;
//     return {
//         ...ownProps,
//         games:games
//     }
//     // const {games, balls, ball} = state;
//     // return {
//     //      games,
//     //      balls,
//     //      ball
//     // };
// }
// export default connect(mapStateToProps)(BingoPage);
export default BingoPage;