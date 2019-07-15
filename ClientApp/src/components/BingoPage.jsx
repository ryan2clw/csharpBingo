import React from 'react';
import { connect } from 'react-redux';
import Board from '../store/BingoBoard';


class BingoPage extends React.Component {

    render() {
        return (
            <Board>
                {console.log("bingoProps", this.props)}
                {console.log("bingoState", this.state)}
            </Board>
        );
    }
}
function mapStateToProps(state) {
    const {game} = state;
    return {
         game
    };
}
export default connect(mapStateToProps)(BingoPage);