import React from 'react'
import './Header.css'

const Header = ({ imgHeader, altHeader, textHeader }) => {
  return (
    <>
      <div className='img'>
        <img src={imgHeader} alt={altHeader} />
      </div>
      <div  className='text'>
        <h1>{textHeader}</h1>
      </div>
    </>
  )
}

export default Header