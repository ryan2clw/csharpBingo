import React from 'react';
import { Router, Route } from 'react-router-dom';
import { connect } from 'react-redux';
//import { clear } from './store/Message';
import { Layout } from './components/Layout';
import LoginPage from './components/LoginPage'
import HomePage from './components/HomePage';
import CounterPage from './components/CounterPage';
import WeatherPage from './components/WeatherPage';
import PrivateRoute from './components/PrivateRoute';
import { history } from './store/history';

class App extends React.Component {
  // constructor(props) {
  //     super(props);

  //     const { dispatch } = this.props;
  //     history.listen((location, action) => {
  //       dispatch(clear());
  //     });
  // }

  render() {
      const { alert } = this.props;
      console.log("alert", alert);
      return (
          <div>
                  <Router history={ history }>
                      <Layout>
                      {this.props.alert &&
                            <div className={`alert ${this.props.alert.type}`}>{this.props.alert.message}</div>
                        }
                          <PrivateRoute exact path="/" component={ HomePage } />
                          <Route path="/login" component={ LoginPage} />
                          <Route path='/home' component={HomePage} />
                          <Route path='/counter' component={CounterPage} />
                          <Route path='/fetch-data/:startDateIndex?' component={ WeatherPage } />
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
  