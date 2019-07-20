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
        if(this.props.height === "50px")
            console.log("bingoBoard propSQUARE IS MADE", props);
    }

  width = () => this.props.width || "54px";
  height = () => this.props.height || "54px";
  render() {
    return(
      <FlexHeight background={this.props.background} height={this.height()} w={this.width()} p={1} justify='center' align='center' className={'ticket-number ' + (this.props.called ? 'called' : '')}>
          {this.props.ticketNumber}
          {this.props.height === "50px" && console.log("CARD SQUARE IS RENDERED")}
      </FlexHeight>
    )
  }
}
Square.propTypes = {
  ticketNumber: PropTypes.string,
  called: PropTypes.bool,
};
function mapStateToProps(state, ownProps) {
    if(ownProps.height === "50px"){
        console.log("<---------Initializes with SQUARE RENDERED below, # of Squares that this function checks--------------------------------------------->", ownProps);
    }    
    return ownProps;
}
export default connect(mapStateToProps)(Square);






    // const { balls } = state.balls;
    // if (balls && balls.includes(ownProps.ticketNumber)) {           
    //     if(!ownProps.isCalled){
    //         let newProps = { ...ownProps};
    //         newProps.isCalled = true;
    //         newProps.background = "green";
    //         console.log("FOUND NEW TICKET from state---------->", state);      
    //         return newProps;
    //     }
    // };