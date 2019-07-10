import { evnt } from './events';
import { authService} from '../webservices/authService';
import { history } from './history';
import { danger } from './Message';

export const actionCreators = {
    loginRequest: (username,password) => async (dispatch, getState) => {
        function request(user) { return { type: evnt.LOGIN_REQUEST, user } }
        function success(user) {  return {  type: evnt.LOGIN_SUCCESS, user } }
        function failure(error) { return { type: evnt.LOGIN_FAILURE, error } }
        dispatch(request({username}));
        authService.login(username, password)
            .then(
                user => { 
                    dispatch(success(user));
                    history.push('/');
                },
                error => {
                    dispatch(failure(evnt.LOGIN_FAILURE, error.toString()));
                    dispatch(danger(error.toString()));
                }
            );
    },
    logout: () => { 
        authService.logout();
        return { type: evnt.LOGOUT };
    }
};
let user = JSON.parse(localStorage.getItem('user'));
const initialState = user ? { loggedIn: true, user } : {};

export function authentication(state = initialState, action) {
  switch (action.type) {
    case evnt.LOGIN_REQUEST:
      return {
        loggingIn: true,
        user: action.user
      };
    case evnt.LOGIN_SUCCESS:
      return {
        loggedIn: true,
        loggingIn: false,
        user: action.user
      };
    case evnt.LOGIN_FAILURE:
      return {};
    case evnt.LOGOUT:
      return {};
    default:
      return state
  }
}