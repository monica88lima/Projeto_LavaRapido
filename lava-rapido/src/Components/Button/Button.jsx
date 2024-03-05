import React from 'react'
import { Button as ButtonAntd } from 'antd';

const Button = ({textButton}) => {
  return (
    <div>
        <ButtonAntd>{textButton}</ButtonAntd>
    </div>
  )
}

export default Button