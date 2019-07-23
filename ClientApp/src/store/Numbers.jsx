import { evnt } from './events';
import {numberService} from '../webservices/numberService';
import { danger } from './Message';

export const actionCreators = {
    requestNumbers: (cardCount=1, games) => async (dispatch, getState) => {
        function request(games) { return { type: evnt.NUMBERS_REQUEST, games, cardCount } }
        function success(games) {  return {  type: evnt.NUMBERS_SUCCESS, games, cardCount } }
        function failure(error) { return { type: evnt.NUMBERS_FAILURE, error } }
        dispatch(request({games}));
        numberService.card(cardCount)
            .then(
                games => { 
                    return dispatch(success(games));
                },
                error => {
                    dispatch(failure(evnt.NUMBERS_FAILURE, error.toString()));
                    dispatch(danger(error.toString()));
                }
            );
    }
};
/* Reducers map actions to state, set the default state to an initial value */
export const gamesReducer = (state = { games: [], isLoading: false }, action) => {
    /* 
          State is immutable, so you unpack the original state, 
        then you set the new state.whatever = action.whatever,
        changing the state's properties but not state itself
    */
    switch (action.type) {
        case evnt.NUMBERS_REQUEST:
            return {
                games: action.games,
                cardCount: action.cardCount,
                isLoading: true
            };
        case evnt.NUMBERS_SUCCESS:
        {
            /* Successful API call so update dynamic data: state.whatever = action.whatever */
            return {
                cardCount: action.cardCount,
                games: action.games || [],
                isLoading: false
            };
        }
        case evnt.NUMBERS_FAILURE:
            return {
                loggingIn: false,
                error: action.error
            };
        default:
            return state;
    }
};