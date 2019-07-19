import React from 'react';
import styled from 'styled-components';
import PropTypes from 'prop-types';
import { Flex } from 'reflexbox';
import { connect } from 'react-redux';
import './styles/Square.css';

/**
 * This component is a small number square which makes up a row on a player
 * ticket. The component manages style based on whether or not the 'called' prop
 * is passed down to it.
 * @class
 */
const FlexHeight = styled(Flex)`
  height: ${props => props.height || "54px"};
  background: ${props => props.background};
`;

class Square extends React.Component {

  constructor(props){
    super(props); 
    if(this.props.height==="40px")
      console.log("SQUARE PROPS", this.props);
  }

  width = () => this.props.width || "54px";
  height = () => this.props.height || "54px";
  back = () => this.props.ballsCalled.includes(this.props.ticketNumber) ? "green" : "black";
  render() {
    return(
      <FlexHeight background={this.back()} height={this.height()} w={this.width()} p={1} justify='center' align='center' className={'ticket-number ' + (this.props.called ? 'called' : '')}>
          {this.props.ticketNumber}
      </FlexHeight>
    )
  }
}
Square.propTypes = {
  ticketNumber: PropTypes.string,
  called: PropTypes.bool,
};
function mapStateToProps(state, ownProps) {
    const { balls } = state.balls;
    const ticketNumber = ownProps.ticketNumber || "AVOID NULL AT ALL COSTS";
    if (balls && balls.includes(ticketNumber)) {
        let newProps = { ...ownProps };
        newProps.background = "green";
        console.log("FOUND NEW TICKET", ticketNumber);
    };
    let ret = {
        ballsCalled: balls || [],
        ...ownProps
    };
    console.log("-----------------------------ret", ret);
    return ret;
}
export default connect(mapStateToProps)(Square);