import React from 'react'
import './Sidebar.css'

const Sidebar = ({ isOpen }) => {
    const handleSubmitExit = () => {
        localStorage.setItem('isLoggedIn', false);
    };

    return (
        <div className={`sidebar ${isOpen ? 'active' : ''}`}>
            <div className='top'>
                <a href="/">
                    <p>MENU</p>
                </a>
            </div>
            <div className='bottom'>
                <ul>
                    <li><a href="/agendamento"><img src="icons/icons8-agenda-64.png" alt="" className='icon' />Agendamento</a></li>
                    <li><a href="/status"><img src="icons/icons8-status-64.png" alt="" className='icon' />Status</a></li>
                    <li><a href="/servicos"><img src="icons/icons8-servicos.png" alt="" className='icon' />Serviços</a></li>
                    <li><a href="/orcamentos"><img src="icons/icons8-orçamento-48.png" alt="" className='icon' />Orçamentos</a></li>
                    <li><a href="/contato"><img src="icons/icons8-telefone-64 (2).png" alt="" className='icon' />Contato</a></li>
                    <li><a href="/relatorios"><img src="icons/icons8-editar-o-relatório-de-gráfico-de-pizza-48.png" alt="" className='icon' />Relatorios</a></li>
                    <li onClick={handleSubmitExit}><a href="/login"><img src="icons/sair.png" alt="" className='icon' />Sair</a></li>
                </ul>
            </div>
        </div>
    )
}

export default Sidebar