import React from 'react'
import './Sidebar.css'

const Sidebar = ({ isOpen }) => {
    return (
        <div className={`sidebar ${isOpen ? 'active' : ''}`}>
            <div className='top'>
                <p>MENU</p>
            </div>
            <div className='bottom'>
                <img src="https://placehold.co/64x64" alt="" className='avatar' />
                <p className='name-user'>LOGIN</p>
                <ul>
                    <li><a href="#"><img src="icons/icons8-agenda-64.png" alt="" className='icon'/>Agendamento</a></li>
                    <li><a href="#"><img src="icons/icons8-status-64.png" alt="" className='icon'/>Status</a></li>
                    <li><a href="#"><img src="icons/icons8-servicos.png" alt="" className='icon'/>Serviços</a></li>
                    <li><a href="#"><img src="icons/icons8-orçamento-48.png" alt="" className='icon'/>Orçamentos</a></li>
                    <li><a href="#"><img src="icons/icons8-telefone-64 (2).png" alt="" className='icon'/>Contato</a></li>
                    <li><a href="#"><img src="icons/icons8-editar-o-relatório-de-gráfico-de-pizza-48.png" alt="" className='icon'/>Relatorios</a></li>
                </ul>
            </div>
        </div>
    )
}

export default Sidebar