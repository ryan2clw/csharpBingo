import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';

import { actionCreators } from '../store/User';

class HomePage extends React.Component {

    handleDeleteUser(id) {
        return (e) => this.props.dispatch(actionCreators.delete(id));
    }

    render() {
        const {user} = this.props;
        console.log("user", user);
        const myBalance = new Intl.NumberFormat('en-US', 
            { style: 'currency', currency: 'USD' }
        ).format(user.player.balances[0].amount);
        return (
            <div className="container">
                <h1>Hi {user.player.firstName} {user.player.lastName} !</h1>
                <p>You're logged in with React!!</p>
                <p>
                    <Link to="/lobby">How about ordering some Bingo games, you have a balance of:  { myBalance }</Link>
                </p>
                <p>
                    <Link to="/lobby">Wait for game in lobby</Link>
                </p>
                <p>
                    <Link to="/login">Logout</Link>
                </p>
            </div>
        );
    }
}
function mapStateToProps(state) {
    const {user} = state.authentication;
    return {
         user
    };
}
export default HomePage = connect(mapStateToProps)(HomePage);