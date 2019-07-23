import { evnt } from './events';
import {numberService} from '../webservices/numberService';
import { danger } from './Message';

export const ballAction = {
    getRounds: () => async (dispatch, getState) => {
        const oldies = getState().balls.balls;
        function request(balls) { return { type: evnt.ROUND_REQUEST , balls } }
        function success(balls) {  return {  type: evnt.ROUND_SUCCESS, balls } }
        function failure(error) { return { type: evnt.ROUND_FAILURE, error } }
        dispatch(request(oldies));
        numberService.rounds()
            .then(
                balls => { 
                    return dispatch(success(balls));
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

    switch (action.type) {
        case evnt.ROUND_REQUEST:
            return {
                balls: state.balls,
                isLoading: true
            };
        case evnt.ROUND_SUCCESS:
            return {
                balls: action.balls
            };
        case evnt.ROUND_FAILURE:
            return {
                error: action.error
            };
        default:
            return state;
    }
};