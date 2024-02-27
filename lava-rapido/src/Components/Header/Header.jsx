import React from 'react'

const Header = ({imgHeader, altHeader, textHeader}) => {
  return (
    <div className='header'>
        <img src={imgHeader} alt={altHeader}/>
        <h1>{textHeader}</h1>
    </div>
  )
}

export default Header