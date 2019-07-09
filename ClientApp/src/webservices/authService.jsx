import { handleResponse } from '../store/events';
import { error } from '../store/Message';
import { evnt } from '../store/events';

const failure = (error) => { return { type: evnt.LOGIN_FAILURE, error } }

const login = async (username, password) => {
    let headers = {
        'Content-Type': 'application/x-www-form-urlencoded'
    };
    let body = new URLSearchParams({
        username: username,
        password: password,
        Key: "8e22faa5-6f9e-4488-8efd-af1e8fcc7d6f",
        Token: null
    });
    const requestOptions = {
        method: 'POST',
        headers: headers,
        body: body
    };
    return fetch("http://localhost:60128/api/WalletAPI/GetPlayerInfo", requestOptions)
        .then(handleResponse)
        .then(user => {
            // store user details and jwt token in local storage to keep user logged in between page refreshes
            localStorage.setItem('user', JSON.stringify(user));
            return user;
        },
        error => {
            failure(evnt.LOGIN_FAILURE, error.toString());
            //error(error.toString());
        });
    }

const logout = () => {
    // remove user from local storage to log user out
    localStorage.removeItem('user');
}
export const authService = {
    login,
    logout
};