import React from 'react';
import NavMenu from './NavMenu';
import styled from 'styled-components';

const GreyDiv = styled.div`
    background: #076461;
    height: 900px;
`

export const Layout = (props) => (
    <div>
        <NavMenu />
        <GreyDiv>
            { props.children }
        </GreyDiv>
    </div>
);