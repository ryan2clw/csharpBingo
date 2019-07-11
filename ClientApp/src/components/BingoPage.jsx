import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';
import { Board } from '../store/BingoBoard';


class BingoPage extends React.Component {

    // constructor(props) {
    //     super(props);
    //     // reset login status   
    //     this.handleChange = this.handleChange.bind(this);
    //     this.handleSubmit = this.handleSubmit.bind(this);
    //     console.log("LoginPage props", this.props);
    // }

    render() {
        const {game} = this.props;
        return (
            <Board>
                
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