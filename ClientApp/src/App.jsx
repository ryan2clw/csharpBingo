import React from 'react';
import { Router, Route } from 'react-router-dom';
import { connect } from 'react-redux';
import { clear } from './store/Message';
import { history } from './store/history';
import { Layout } from './components/Layout';
import LoginPage from './components/LoginPage'
import HomePage from './components/HomePage';
import BingoPage  from './components/BingoPage';
import LobbyPage from './components/LobbyPage';
//import PrivateRoute from './components/PrivateRoute';
import { Flex } from 'reflexbox';



class App extends React.Component {
  constructor(props) {
      super(props);
      history.listen((location, action) => {
        props.dispatch(clear());
      });
  }
  
  render() {
      const { alert } = this.props;
      return (
          <div>
              <Router history={history}>
                  <Layout>
                      <Flex justify='center'>
                        <div className="pt-3">
                            {alert.type &&
                                <div className={`text-center alert ${alert.type}`}>
                                    {alert.message}
                                </div>
                            }
                        </div>
                      </Flex>
                      <Route exact path="/" component={LobbyPage} />
                      <Route path="/login" component={LoginPage} />
                      <Route path='/home' component={HomePage} />
                      <Route path='/play' render={(props) => <BingoPage {...props} cardCount={6} />}/>
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
  