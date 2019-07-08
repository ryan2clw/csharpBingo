import React from 'react';
import { Container } from 'reactstrap';
import NavMenu from './NavMenu';

export default props => (
    <div>
        <NavMenu />
        <Container>
                <div className="row">
                    <div className="col-sm-8 col-sm-offset-2">
                        {//message.message && <div className={`alert ${message.type}`}>{message.message}</div>
                            <div className='alert alert-info'>This is where the messages should go.</div>
                        }
                    </div>
                </div>
            {props.children}
        </Container>

    </div>
);