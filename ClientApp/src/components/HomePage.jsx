import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';

class HomePage extends React.Component {

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
                    <Link to="/play">How about ordering some Bingo games, you have a balance of:  { myBalance }</Link>
                </p>
                <p>
                    <Link to="/play">Wait for game in lobby</Link>
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