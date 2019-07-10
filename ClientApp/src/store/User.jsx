import { evnt } from './events';
import { authService} from '../webservices/authService';
import { error } from './Message';
import { history } from './history';

export const actionCreators = {
    loginRequest: (username,password) => async (dispatch, getState) => {
        /* Make API request and send action.object to the reducer */
        const currentUser = getState().user;
        if (username === currentUser.username) {
            return; /* avoid duplicates */
        }
        dispatch({ type: evnt.LOGIN_REQUEST });
            console.log("state", getState());
            const user = await authService.login(username, password);
            console.log("user", user);
            if(user && user.player){
                dispatch({ type: evnt.LOGIN_SUCCESS, user });
                history.push('/');
                return user;
            }else{
                // MARK TO DO ADD ERROR HERE
                dispatch({ type: evnt.ERROR, message:"ERR0R" });
                dispatch(error(error.toString()));
                history.push('/login');
            }
    },
    logout: () => { authService.logout() }
};
export const userReducer = (state, action) => {
    const user = JSON.parse(localStorage.getItem('user'));
    const initialState = user ? { loggedIn: true, user } : {};
    state = state || initialState;
    //alert(JSON.stringify(action));
    switch (action.type) {
        case evnt.LOGIN_REQUEST:
            return {
                ...state,
                submitted: true,
                loggingIn: true,
            };
        case evnt.LOGIN_SUCCESS:
            return {
                ...state,
                loggedIn: true,
                user: action.user
            };
        case evnt.LOGIN_FAILURE:
            return {
                message: action.message
            };
        case evnt.LOGOUT:
            return {};
        default:
            return state
    }
};