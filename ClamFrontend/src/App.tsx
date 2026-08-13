import React from 'react'
import { useState } from 'react'
import { Route , Routes } from 'react-router-dom'
import './App.css'
import AuthenticationPage from './pages/AuthenticationPage'

function App() {
  return (
    <div className='App' >
      <main className='content'>
        <Routes>
          <Route path='/authentication' element={<AuthenticationPage />}/>
        </Routes>
      </main>
    </div>
  )

}

export default App
