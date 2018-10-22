import React from 'react';
import {Label, Input, FormFeedback} from 'reactstrap';


const RenderFieldUpdate = (props) => {
  const {input, input: { name} , label, placeholder, type, meta: {error, touched, pristine}} = props;
  console.log(error && touched);
  return (
    <div className="px-0 py-0">
        <Label for={ name }>{ label }</Label>
        <Input valid={ touched && !error && !pristine} invalid={ touched && error } {...input} name={ name } id={ name } placeholder={ placeholder } type={type}></Input>
        <FormFeedback>{ error }</FormFeedback>
    </div>
  )
}

export default RenderFieldUpdate;