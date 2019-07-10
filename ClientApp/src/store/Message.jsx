import { evnt } from './events';

/* My Actions, you don't need an actionCreator, it makes it convenient, but you can also just define actions */

export const success = (message) => ({ type: 'alert-success', message });
export const danger = (message) => ({ type: 'alert-danger', message });
export const clear = () => ({ type: evnt.CLEAR });

export function messageReducer(state = {}, action) {
  switch (action.type) {
    case 'alert-success':
      return {
        type: 'alert-success',
        message: action.message
      };
    case 'alert-danger':
      return {
        type: 'alert-danger',
        message: action.message
      };
    case evnt.SUCCESS:
      return {
        type: 'alert-success',
        message: action.message
      };
    case evnt.ERROR:
      return {
        type: 'alert-danger',
        message: action.message
      };
    case evnt.CLEAR:
      return {};
    default:
      return state
  }
}