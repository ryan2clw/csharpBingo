import React from 'react';
import { connect } from 'react-redux';
import Board from './BingoBoard';
import {actionCreators} from '../store/Numbers'

class BingoPage extends React.Component {

    componentDidMount(){
        this.numbers();
    }

    numbers = () => this.props.dispatch(actionCreators.requestNumbers(1));    

    render() {
        const {games} = this.props;
        return (
            games.games.length ? 
            <Board games={ games }></Board> :
            <h3>DATA LOADING...{console.log("--------------------------NO DATA-------------------games", games.games)}</h3>
        );
    }
}
function mapStateToProps(state) {
    const {games} = state;
    return {
         games
    };
}
export default connect(mapStateToProps)(BingoPage);