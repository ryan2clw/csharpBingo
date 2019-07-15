import React from 'react';
import { Router, Route } from 'react-router-dom';
import { connect } from 'react-redux';
import { clear } from './store/Message';
import { history } from './store/history';
import { Layout } from './components/Layout';
import LoginPage from './components/LoginPage'
import HomePage from './components/HomePage';
import CounterPage from './components/CounterPage';
import WeatherPage from './components/WeatherPage';
import BingoPage  from './components/BingoPage';
import PrivateRoute from './components/PrivateRoute';
import styled from 'styled-components';

const BingoHeader = styled.div`
margin-bottom:5px;
`;

class App extends React.Component {
  constructor(props) {
      super(props);
      const { dispatch } = this.props;
      history.listen((location, action) => {
        dispatch(clear());
      });
  }

  
  render() {
      const { alert } = this.props;
      return (
          <div>
              <Router history={history}>
                  <Layout>
                    <BingoHeader>
                        {alert.type &&
                            <div className={`alert ${alert.type}`}>
                                {alert.message}
                            </div>
                        }
                    </BingoHeader>
                      <PrivateRoute exact path="/" component={HomePage} />
                      <Route path="/login" component={LoginPage} />
                      <Route path='/home' component={HomePage} />
                      <Route path='/counter' component={CounterPage} />
                      <Route path='/fetch-data/:startDateIndex?' component={WeatherPage} />
                      <Route path='/play' component={BingoPage} />
                  </Layout>
              </Router>
          </div>
      );
  }
}
function mapStateToProps(state) {
  const { alert } = state;
  return {
      alert
  };
}
const connectedApp = connect(mapStateToProps)(App);
export { connectedApp as App }; 
  