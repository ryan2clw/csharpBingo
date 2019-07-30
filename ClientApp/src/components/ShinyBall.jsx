import React from 'react';
import Nball from './images/N-Ball.png'; // Tell Webpack this JS file uses this image

const ShinyBall = props => (
        <div class="box">
        <img src={(props && props.letter) || Nball} alt="Ball" />
        <div class="text">
            {console.log(props)}
            <p>{ props.children || 7 }</p>
        </div>
    </div>);

export default ShinyBall;