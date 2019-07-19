import { evnt } from './events';
import {numberService} from '../webservices/numberService';
import { danger } from './Message';

export const ballAction = {
    getRounds: () => async (dispatch, getState) => {
        function request() { return { type: evnt.ROUND_REQUEST } }
        function success(numBas) {  return {  type: evnt.ROUND_SUCCESS, numBas } }
        function failure(error) { return { type: evnt.ROUND_FAILURE, error } }
        dispatch(request());
        numberService.rounds()
            .then(
                numBas => { 
                    return dispatch(success(numBas));
                },
                error => {
                    dispatch(failure(evnt.ROUND_FAILURE, error.toString()));
                    dispatch(danger(error.toString()));
                }
            );
    },
    getRound: () => async (dispatch, getState) => {
        function request() { return { type: evnt.ROUND_REQUEST } }
        function success(numBa) {  return {  type: evnt.ROUND_SUCCESS, numBa } }
        function failure(error) { return { type: evnt.ROUND_FAILURE, error } }
        dispatch(request());
        numberService.round()
            .then(
                numBa => { 
                    return dispatch(success(numBa));
                },
                error => {
                    dispatch(failure(evnt.ROUND_FAILURE, error.toString()));
                    dispatch(danger(error.toString()));
                }
            );
    }
};
/* Reducers map actions to state, set the default state to an initial value */
export const ballsReducer = (state = { balls: [], isLoading: false }, action) => {
    /* 
          State is immutable, so you unpack the original state, 
        then you set the new state.whatever = action.whatever,
        changing the state's properties but not state itself
    */
    switch (action.type) {
        case evnt.ROUND_REQUEST:
            return {
                isLoading: true
            };
        case evnt.ROUND_SUCCESS:
            /* Successful API call so update dynamic data: state.whatever = action.whatever */
            {
            const balls = action.numBas;
            return {
                balls: balls,
                ball: balls[0] || "IDFK",
                isLoading: false
            };
        }
        case evnt.ROUND_FAILURE:
            return {
                error: action.error
            };
        default:
            return state;
    }
};
// export const ballReducer = (state = -1, action) => {
//     /* 
//           State is immutable, so you unpack the original state, 
//         then you set the new state.whatever = action.whatever,
//         changing the state's properties but not state itself
//     */
//     switch (action.type) {
//         case evnt.ROUND_REQUEST:
//             return {
//                 isLoading: true
//             };
//         case evnt.ROUND_SUCCESS:
//             /* Successful API call so update dynamic data: state.whatever = action.whatever */
//             return {
//                 ball: action.numBa,
//                 isLoading: false
//             };
//         case evnt.ROUND_FAILURE:
//             return {
//                 error: action.error
//             };
//         default:
//             return state;
//     }
// };