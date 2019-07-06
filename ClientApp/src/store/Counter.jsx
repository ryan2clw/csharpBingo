import { evnt } from './events';

export const actionCreators = {
  increment: () => ({ type: evnt.incrementCountType }),
  decrement: () => ({ type: evnt.decrementCountType })
};

export const counterReducer = (state, action) => {
  const initialState = { count: 0 };  
  state = state || initialState;

  if (action.type === evnt.incrementCountType) {
    return { ...state, count: state.count + 1 };
  }

  if (action.type === evnt.decrementCountType) {
    return { ...state, count: state.count - 1 };
  }

  return state;
};
