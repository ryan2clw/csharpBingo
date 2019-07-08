import { evnt } from './constants';
const initialState = { count: 0 };

export const actionCreators = {
  increment: () => ({ type: evnt.incrementCountType }),
  decrement: () => ({ type: evnt.decrementCountType })
};

export const reducer = (state, action) => {
  state = state || initialState;

  if (action.type === evnt.incrementCountType) {
    return { ...state, count: state.count + 1 };
  }

  if (action.type === evnt.decrementCountType) {
    return { ...state, count: state.count - 1 };
  }

  return state;
};
