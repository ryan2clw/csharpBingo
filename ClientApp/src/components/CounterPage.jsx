import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { actionCreators } from '../store/Counter';

/* Example of a page with state but no AJAX */

const CounterPage = props => (
  <div>
    <h1>Counter</h1>
    <p>This is a simple example of a React component.</p>
    <p>
      Current count: <strong>{props.count}</strong>
    </p>
    <div>
      <button className="btn btn-primary mr-2" onClick={props.increment}>
        Increment
      </button>
      <button className="btn btn-secondary" onClick={props.decrement}>
        Decrement
      </button>
    </div>
  </div>
);

export default connect(
  state => state.counter,
  dispatch => bindActionCreators( actionCreators, dispatch )
)(CounterPage);
