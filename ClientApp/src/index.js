import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { Provider } from 'react-redux';
import { ConnectedRouter } from 'react-router-redux';
import configureStore from './store/configureStore';
import  App from './App';
import registerServiceWorker from './registerServiceWorker';
import { alertActions } from './store/Message'
import { history } from './store/history';

// Get the application-wide store instance, prepopulating with state from the server where available.
const initialState = window.initialReduxState;
const store = configureStore(history, initialState);
const rootElement = document.getElementById('root');
const { dispatch } = store;
// history.listen((location, action) => {
//     // clear alert on location change
//     dispatch(alertActions.clear());
// });

ReactDOM.render(
  <Provider store={store}>
    <ConnectedRouter history={history}>
      <App dispatch={dispatch} />
    </ConnectedRouter>
  </Provider>,
  rootElement);

registerServiceWorker();