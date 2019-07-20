import React from 'react';
import NavMenu from './NavMenu';
import styled from 'styled-components';

const GreyDiv = styled.div`
    background: #eeeeee;
    min-height: 870px;
`

export const Layout = (props) => (
    <div>
        <NavMenu />
        <GreyDiv className="d-flex flex-column justify-content-flex-start align-items-center">
            {props.children}
            {/* {console.log("Layout props", props)} */}
        </GreyDiv>
    </div>
);