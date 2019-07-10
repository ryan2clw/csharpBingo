import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { Provider } from 'react-redux';
// import { ConnectedRouter } from 'react-router-redux';
import configureStore from './store/configureStore';
import { App } from './App';
import registerServiceWorker from './registerServiceWorker';
// import { clear } from './store/Message'
import { history } from './store/history';

// Get the application-wide store instance, prepopulating with state from the server where available.
const initialState = window.initialReduxState;
const store = configureStore(history, initialState);
const rootElement = document.getElementById('root');
// console.log("_________________________________", dispatch);

ReactDOM.render(
  <Provider store={store}>
    <App />
  </Provider>,
  rootElement);

registerServiceWorker();