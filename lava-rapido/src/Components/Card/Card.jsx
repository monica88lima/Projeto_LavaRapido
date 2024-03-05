import React from 'react'
import { Card as CardAntd } from 'antd';
import './Card.css'

const Card = ({ imgCard, altCard, title }) => {
    return (
        <div>
            <CardAntd className="card">
                <img alt={altCard} src={imgCard} />
                <p className='title'>{title}</p>
            </CardAntd>
        </div>
    )
}

export default Card