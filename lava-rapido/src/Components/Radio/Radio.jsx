import React from 'react'
import { Radio as RadioAntd } from 'antd';
import './Radio.css'

const Radio = ({ value, options, onChange }) => {
  return (
    <div className="radio-group">
      <RadioAntd.Group onChange={onChange} value={value}>
        {options.map((option, index) => (
          <RadioAntd buttonStyle={"solid"} key={index} value={index}>{option}</RadioAntd>
        ))}
      </RadioAntd.Group>
    </div>
  );
};

export default Radio;