import React, { useState } from 'react';
import { Route } from 'react-router';
import { connect } from 'react-redux';
import { alertActions } from './store/Message'
import { bindActionCreators } from 'redux';
import { Layout } from './components/Layout';
import LoginPage from './components/LoginPage'
import HomePage from './components/HomePage';
import CounterPage from './components/CounterPage';
import WeatherPage from './components/WeatherPage';
import PrivateRoute from './components/PrivateRoute';

export default (props) =>
  (
  <Layout message={props.message}>
    <PrivateRoute exact path="/" component={ HomePage} />
    <Route path="/login" component={ LoginPage} />
    <Route path='/home' component={HomePage} />
    <Route path='/counter' component={CounterPage} />
    <Route path='/fetch-data/:startDateIndex?' component={WeatherPage} />
  </Layout>
  );
// function mapStateToProps(state) {
//   const { message } = state.message || {};
//   return {
//       message
//   };
// }
// // connect to the redux store
// export default App = connect(mapStateToProps)(App);
  