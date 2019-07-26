import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';
import { actionCreators } from '../store/User';
import { Flex } from 'reflexbox';
import styled from 'styled-components';
import SvgIcon from '@material-ui/core/Icon';

const LoginDiv = styled.section`
    font-size: 22px;
    padding-left: 8px;
`;

class LoginPage extends React.Component {
    constructor(props) {
        super(props);
        // reset login status
        this.props.dispatch(actionCreators.logout());
        this.state = {
            username: '',
            password: '',
            submitted: false
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        console.log("LoginPage props", this.props);
    }
    ComponentWillMount() {
        actionCreators.logout();
    }

    handleChange(e) {
        const { name, value } = e.target;
        this.setState({ [name]: value });
    }

    handleSubmit(e) {
        e.preventDefault();
        this.setState({ submitted: true });
        const { username, password } = this.state;
        if (username && password) {
            this.props.dispatch(actionCreators.loginRequest(username, password));
        }
    }

    render() {
        const { loggingIn } = this.props;
        const { username, password, submitted } = this.state;
        return (
            <div className=' d-flex flex-row flex-grow-1 justify-content-center'>
                <div className='bg-light p-3 mb-5 mt-4 rounded wider'>

                    <form className="px-3" name="form" onSubmit={this.handleSubmit}>
                        <div className={'form-group' + (!username ? ' has-error' : '')}>
                        <Flex align='center' className="mb-2">
                            <SvgIcon fontSize="large">account_circle</SvgIcon>
                            <LoginDiv>Login</LoginDiv>
                        </Flex>
                            <input type="text" className="form-control" name="username" value={username} onChange={this.handleChange} required />
                            {(submitted && !username) &&
                                <div className="invalid-feedback help-block">Username is required</div>
                            }
                        </div>
                        <div className={'form-group' + (!password ? ' has-error' : '')}>
                        <Flex align='center' className="mb-2">
                        <SvgIcon fontSize="large">lock</SvgIcon>
                        <LoginDiv>Password</LoginDiv>
                    </Flex>                            <input type="password" className="form-control" name="password" value={password} onChange={this.handleChange} required />
                            {(submitted && !password) &&
                                <div className="invalid-feedback help-block">Password is required</div>
                            }
                        </div>
                        <div className="form-group">
                            <button className="btn blu-hu">Login</button>
                            {loggingIn &&
                                <img src="data:image/gif;base64,R0lGODlhEAAQAPIAAP///wAAAMLCwkJCQgAAAGJiYoKCgpKSkiH/C05FVFNDQVBFMi4wAwEAAAAh/hpDcmVhdGVkIHdpdGggYWpheGxvYWQuaW5mbwAh+QQJCgAAACwAAAAAEAAQAAADMwi63P4wyklrE2MIOggZnAdOmGYJRbExwroUmcG2LmDEwnHQLVsYOd2mBzkYDAdKa+dIAAAh+QQJCgAAACwAAAAAEAAQAAADNAi63P5OjCEgG4QMu7DmikRxQlFUYDEZIGBMRVsaqHwctXXf7WEYB4Ag1xjihkMZsiUkKhIAIfkECQoAAAAsAAAAABAAEAAAAzYIujIjK8pByJDMlFYvBoVjHA70GU7xSUJhmKtwHPAKzLO9HMaoKwJZ7Rf8AYPDDzKpZBqfvwQAIfkECQoAAAAsAAAAABAAEAAAAzMIumIlK8oyhpHsnFZfhYumCYUhDAQxRIdhHBGqRoKw0R8DYlJd8z0fMDgsGo/IpHI5TAAAIfkECQoAAAAsAAAAABAAEAAAAzIIunInK0rnZBTwGPNMgQwmdsNgXGJUlIWEuR5oWUIpz8pAEAMe6TwfwyYsGo/IpFKSAAAh+QQJCgAAACwAAAAAEAAQAAADMwi6IMKQORfjdOe82p4wGccc4CEuQradylesojEMBgsUc2G7sDX3lQGBMLAJibufbSlKAAAh+QQJCgAAACwAAAAAEAAQAAADMgi63P7wCRHZnFVdmgHu2nFwlWCI3WGc3TSWhUFGxTAUkGCbtgENBMJAEJsxgMLWzpEAACH5BAkKAAAALAAAAAAQABAAAAMyCLrc/jDKSatlQtScKdceCAjDII7HcQ4EMTCpyrCuUBjCYRgHVtqlAiB1YhiCnlsRkAAAOwAAAAAAAAAAAA==" alt="spinner" />
                            }
                            <Link to="/register" className="btn btn-link">Register</Link>
                        </div>
                    </form>
                </div>
            </div>
        );
    }
}

function mapStateToProps(state) {
    const { loggingIn } = state.authentication;
    return {
        loggingIn
    };
}
// connect to the redux store
export default LoginPage = connect(mapStateToProps)(LoginPage);