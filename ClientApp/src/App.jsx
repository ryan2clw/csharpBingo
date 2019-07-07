import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import LoginPage from './components/LoginPage'
import HomePage from './components/HomePage';
import CounterPage from './components/CounterPage';
import WeatherPage from './components/WeatherPage';

export default () => (
  <Layout>
    <Route exact path='/' component={LoginPage} />
    <Route path='/home' component={HomePage} />
    <Route path='/counter' component={CounterPage} />
    <Route path='/fetch-data/:startDateIndex?' component={WeatherPage} />
  </Layout>
);
