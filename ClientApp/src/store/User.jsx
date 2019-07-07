import { evnt } from './events';
import { authService} from '../webservices/authService';

export const actionCreators = {
    loginRequest: (username,password) => async (dispatch, getState) => {
        /* Make API request and send action.object to the reducer */
        const currentUser = getState().user;
        if (username === currentUser.username) {
            return; /* avoid duplicates */
        }
        dispatch({ type: evnt.LOGIN_REQUEST });        
        const user = authService.login(username, password);
        dispatch({ type: evnt.LOGIN_SUCCESS, user });
    },
    logout: () => { authService.logout() }
};
export const userReducer = (state, action) => {
    const user = JSON.parse(localStorage.getItem('user'));
    const initialState = user ? { loggedIn: true, user } : {};
    state = state || initialState;
    switch (action.type) {
        case evnt.LOGIN_REQUEST:
            return {
                ...state,
                loggingIn: true,
            };
        case evnt.LOGIN_SUCCESS:
            return {
                ...state,
                loggedIn: true,
                user: action.user
            };
        case evnt.LOGIN_FAILURE:
            return {};
        case evnt.LOGOUT:
            return {};
        default:
            return state
    }
};