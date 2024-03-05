import React from 'react'
import { Input as InputAntd } from 'antd';

const Input = ({placeholder = ""}) => {
  return (
    <div>
        <InputAntd placeholder={placeholder}/>
    </div>
  )
}

export default Input