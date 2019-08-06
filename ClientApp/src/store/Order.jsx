import { evnt } from './events';
import {numberService} from '../webservices/numberService';
import { danger } from './Message';

export const ballAction = {
    buyCards: () => async (dispatch, getState) => {
        const oldies = getState().balls.balls;
        function request(balls) { return { type: evnt.CARD_REQUEST , balls } }
        function success(balls) {  return {  type: evnt.CARD_SUCCESS, balls } }
        function failure(error) { return { type: evnt.CARD_FAILURE, error } }
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
                numBa => dispatch(success(numBa)),
                error => {
                    dispatch(failure(evnt.ROUND_FAILURE, error.toString()));
                    dispatch(danger(error.toString()));
                }
            );
    }
};
/* Reducers map actions to state, set the default state to an initial value */
export const ballsReducer = (state = { balls: [], cardStatus:{}, isLoading: false }, action) => {

    switch (action.type) {
        case evnt.ROUND_REQUEST:
            return {
                balls: state.balls,
                isLoading: true
            };
        case evnt.ROUND_SUCCESS:
            return {
                balls: action.balls.ballsBlown,
                cardStatus:  action.balls.numbersLeftOnCard
            };
        case evnt.ROUND_FAILURE:
            return {
                error: action.error
            };
        default:
            return state;
    }
};