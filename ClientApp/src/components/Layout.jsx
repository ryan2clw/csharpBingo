import React from 'react';
import NavMenu from './NavMenu';
import styled from 'styled-components';

const GreyDiv = styled.div`
    background: #eeeeee;
    min-height: 460px;
`

export const Layout = (props) => (
    <div>
        <NavMenu />
        <GreyDiv className="d-flex flex-column justify-content-center align-items-center">
            {props.children}
        </GreyDiv>
    </div>
);