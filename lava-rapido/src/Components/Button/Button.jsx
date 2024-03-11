import React from 'react'

const Button = ({type, children, className = ''}) => {
  return (
    <div>
        <button type={type} className={className}>{children}</button>
    </div>
  )
}

export default Button