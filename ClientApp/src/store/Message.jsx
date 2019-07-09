// import { evnt } from './events';

// export const actionCreators = {
//     success: (message) => ({ type: evnt.MESSAGE_SUCCESS }),
//     error: (message) => ({ type: evnt.MESSAGE_ERROR }),
//     clear: () => ({ type: evnt.MESSAGE_CLEAR })
// };

// export const messageReducer = (state = {}, action) => {
//     // Switches the bootstrap class to indicate green-bg success or red-bg failure
//     switch (action.type) {
//       case evnt.MESSAGE_SUCCESS:
//         return {
//           type: 'alert-success',
//           message: action.message
//         };
//       case evnt.MESSAGE_ERROR:
//         return {
//           type: 'alert-danger',
//           message: action.message
//         };
//       case evnt.MESSAGE_CLEAR:
//         return {};
//       default:
//         return state
//     }
//   }
import { evnt } from './events';

export const success = (message) => ({ type: evnt.SUCCESS, message });
export const error = (message) => ({ type: evnt.ERROR, message });
export const clear = () => ({ type: evnt.CLEAR });
// };

// function success(message) {
//     return { type: evnt.SUCCESS, message };
// }

// function error(message) {
//     return { type: evnt.ERROR, message };
// }

// function clear() {
//     return { type: evnt.CLEAR };
// }

export function messageReducer(state = {}, action) {
  switch (action.type) {
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