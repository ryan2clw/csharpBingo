import React from 'react';
import NavMenu from './NavMenu';

export const Layout = (props) => (
    <div>
        <NavMenu />
        <div className="dope-gradient">
            { props.children }
        </div>
    </div>
);