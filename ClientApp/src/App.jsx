import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import LoginPage from './components/LoginPage'
import HomePage from './components/HomePage';
import CounterPage from './components/CounterPage';
import WeatherPage from './components/WeatherPage';
import PrivateRoute from './components/PrivateRoute';

export default () => (
  <Layout>
    <PrivateRoute exact path="/" component={ HomePage} />
    <Route path="/login" component={ LoginPage} />
    <Route path='/home' component={HomePage} />
    <Route path='/counter' component={CounterPage} />
    <Route path='/fetch-data/:startDateIndex?' component={WeatherPage} />
  </Layout>
);
