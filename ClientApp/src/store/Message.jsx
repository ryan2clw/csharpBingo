import { evnt } from './events';

// export const alertActions = {
//     success,
//     error,
//     clear
// };

// function success(message) {
//     return { type: evnt.MESSAGE_SUCCESS, message };
// }

// function error(message) {
//     return { type: evnt.MESSAGE_ERROR, message };
// }

// function clear() {
//     return { type: evnt.9MESSAGE_CLEAR };
// }
export const actionCreators = {
    success: (message) => ({ type: evnt.MESSAGE_SUCCESS }),
    error: (message) => ({ type: evnt.MESSAGE_ERROR }),
    clear: () => ({ type: evnt.MESSAGE_CLEAR })
};

export const messageReducer = (state = {}, action) => {
    // Switches the bootstrap class to indicate green-bg success or red-bg failure
    switch (action.type) {
      case evnt.MESSAGE_SUCCESS:
        return {
          type: 'alert-success',
          message: action.message
        };
      case evnt.MESSAGE_ERROR:
        return {
          type: 'alert-danger',
          message: action.message
        };
      case evnt.MESSAGE_CLEAR:
        return {};
      default:
        return state
    }
  }